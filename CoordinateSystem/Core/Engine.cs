using CoordinateSystem.IO;
using System;
using System.IO;
using System.Linq;
using System.Text;

namespace CoordinateSystem.Core
{
    public class Engine : IEngine
    {
        private readonly IController controller;
        private readonly IWriter writer;

        public Engine()
        {
            this.controller = new Controller();
            this.writer = new Writer();
        }

        public void Run()
        {
            using (var reader = new StreamReader("input.txt"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();

                    var splitedInput = line.Split(new char[] { '(', ',', ')' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    var name = splitedInput[0];
                    var x = double.Parse(splitedInput[1]);
                    var y = double.Parse(splitedInput[2]);

                    try
                    {
                        this.controller.AddPoint(name, x, y);
                    }
                    catch (Exception ex)
                    {

                        throw new ArgumentException(ex.Message);
                    }
                }
            }
            this.writer.WriteLine(this.controller.ReturnsTheFurthestPointInformation());
        }
    }
}
