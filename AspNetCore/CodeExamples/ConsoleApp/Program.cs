using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Text;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (IConnection connection = factory.CreateConnection())
            using (IModel channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "Borsoft",
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                var consumer = new EventingBasicConsumer(channel);
                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body;
                    var message = Encoding.UTF8.GetString(body);
                    Person person = JsonConvert.DeserializeObject<Person>(message);
                    Console.WriteLine($" Adı: {person.Name} Soyadı:{person.SurName} [{person.Message}]");
                };
                channel.BasicConsume(queue: "Borsoft", true, consumer: consumer);

                Console.WriteLine(" İşe Alındınız. Teşekkürler :)");
                Console.ReadLine();
            }
        }
    }
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Message { get; set; }
    }
}
