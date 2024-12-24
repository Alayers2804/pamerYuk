using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace projectUAS
{
    public static class FormManager
    {
        private static Stack<Form> formStack = new Stack<Form>();

        public static void Push(Form form)
        {
            formStack.Push(form);
        }

        public static Form Pop()
        {
            return formStack.Count > 0 ? formStack.Pop() : null;
        }

        public static Form Peek()
        {
            return formStack.Count > 0 ? formStack.Peek() : null;
        }

        public static void ClearAndShow(Form newForm)
        {
            // Hide all forms in the stack
            while (formStack.Count > 0)
            {
                Form form = formStack.Pop();
                form.Hide(); 
            }

            // Show the new form
            newForm.Show();
            Push(newForm);
        }
    }
}
