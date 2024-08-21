using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module01Exercise01
{
    public class WelcomeDate : IMarkupExtension
    {
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return $"Welcome, User! Today is {DateTime.Now:MMMM dd, yyyy}";

        }
    }
}
