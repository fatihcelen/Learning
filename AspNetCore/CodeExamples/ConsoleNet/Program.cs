using Newtonsoft.Json;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person() { Name = "Bora", SurName = "Kasmer", ID = 1, BirthDate = new DateTime(1978, 6, 3), Message = "İlgili aday yakınımdır :)" };
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (IConnection connection = factory.CreateConnection())
            using (IModel channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "Borsoft",
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                string message = JsonConvert.SerializeObject(person);
                var body = Encoding.UTF8.GetBytes(message);

                channel.BasicPublish(exchange: "",
                                     routingKey: "Borsoft",
                                     basicProperties: null,
                                     body: body);
                Console.WriteLine($"Gönderilen kişi: {person.Name}-{person.SurName}");
            }

            Console.WriteLine(" İlgili kişi gönderildi...");
            Console.ReadLine();
        }
    }
}
