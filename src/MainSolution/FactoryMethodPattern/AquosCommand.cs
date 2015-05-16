using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    /// <summary>
    /// Class responsible for handling control commands to Sharp Aquos tv  
    /// </summary>
    public class AquosCommand
    {
        protected const int CommandMaxLength = 4;
        protected const int ParamMaxLength = 4;

        public string Command { get; private set; }
        public string Parameter { get; private set; }
               
        public AquosCommand(string command, string parameters = null)
        {
            if (string.IsNullOrEmpty(command))
            {
                throw new ArgumentNullException("command");
            }

            command = command.Trim();

            // Command cannot be larger than 4 characters
            if (command.Length > CommandMaxLength)
            {
                throw new ArgumentException("Command cannot be more than four characters");
            }

            if (string.IsNullOrEmpty(parameters))
            {
                parameters = string.Empty;
            }

            // Parameters cannot be larger than 4 character
            if (parameters.Length > ParamMaxLength)
            {
                throw new ArgumentException("Command parameters cannot be more than four characters");
            }

            parameters = parameters.Trim();

            Command = command;
            Parameter = parameters.PadRight(ParamMaxLength); // because parametrs send to tv must be 4 char long

        }

        // NOTE: if you create multiple overload contructor for particular class it is good idea
        //       to rethink overall design, because using multiple contructor overall in bad pattern

        //public AquosCommand(string command, int value)
        //    : this(command, Convert.ToString(value))
        //{
        //}

        //public AquosCommand(string command, PowerSetting setting) : this(command, (int)setting) 
        //{ 
        //}

        // Factory methods for volume and power command
        public static AquosCommand Volume(int value)
        {
            return new AquosCommand("VOLM", Convert.ToString(value));
        }

        public static AquosCommand Power(PowerSetting setting)
        {
            return new AquosCommand("POWR", Convert.ToString((int)setting));
        }

        /// <summary>
        /// Use for binding command code and parameter into command sended to execute on tv
        /// </summary>
        /// <returns>binded command code with parameter</returns>
        public override string ToString()
        {
            return string.Format("{0}{1}",Command,Parameter);
        }
    }
}
