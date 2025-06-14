using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Threading;

namespace BarberShop
{

    public class Barber
    {
        private readonly object _lock = new object();
        private bool _isSleeping = true;
        private readonly Queue<Customer> _waitingCustomers = new Queue<Customer>();
        private readonly int _waitingChairsCount;
        private int _occupiedWaitingChairs = 0;
        private readonly CancellationToken _cancellationToken;

        public Barber(int waitingChairsCount, CancellationToken cancellationToken)
        {
            _waitingChairsCount = waitingChairsCount;
            _cancellationToken = cancellationToken;
        }

        public void StartWork()
        {
            while (!_cancellationToken.IsCancellationRequested)
            {
                if (_isSleeping)
                {
                    Console.WriteLine("Перукар спить...");
                    try
                    {
                        Thread.Sleep(1000);
                    }
                    catch (ThreadInterruptedException)
                    {
                        break;
                    }
                }
                else
                {
                    Customer customer = null;
                    lock (_lock)
                    {
                        if (_waitingCustomers.Count > 0)
                        {
                            customer = _waitingCustomers.Dequeue();
                            _occupiedWaitingChairs--;
                        }
                        else
                        {
                            _isSleeping = true;
                        }
                    }

                    if (customer != null)
                    {
                        Console.WriteLine($"Перукар стриже клієнта {customer.Name} (ID: {customer.Id})");
                        try
                        {
                            Thread.Sleep(2000);
                        }
                        catch (ThreadInterruptedException)
                        {
                            break;
                        }
                        Console.WriteLine($"Перукар закінчив стрижку клієнта {customer.Name}");
                    }
                }
            }
            Console.WriteLine("Перукар закінчує роботу...");
        }

        public bool AddCustomer(Customer customer)
        {
            if (_cancellationToken.IsCancellationRequested)
                return false;

            lock (_lock)
            {
                if (_occupiedWaitingChairs < _waitingChairsCount)
                {
                    _waitingCustomers.Enqueue(customer);
                    _occupiedWaitingChairs++;

                    if (_isSleeping)
                    {
                        _isSleeping = false;
                        Console.WriteLine($"Клієнт {customer.Name} розбудив перукаря");
                    }
                    else
                    {
                        Console.WriteLine($"Клієнт {customer.Name} сів чекати");
                    }
                    return true;
                }
                return false;
            }
        }
    }
}