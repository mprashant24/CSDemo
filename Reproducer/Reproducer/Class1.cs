using System;

namespace Reproducer
{
    public class Class1
    {

        private Object TestFunction(Object newValue)
        {
            if(newValue == null)
            {
                throw new Library.MyException();
            }

            return newValue.ToString();
        }
    }
}
