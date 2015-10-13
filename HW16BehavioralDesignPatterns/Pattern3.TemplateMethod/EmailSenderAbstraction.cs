namespace Pattern3.TemplateMethod
{
    public abstract class EmailSenderAbstraction
    {
        protected EmailSenderAbstraction(string sender, string reciever, string message)
        {
            this.EmailSender = sender;
            this.EmailReciever = reciever;
            this.Message = message;
        }

        protected string EmailSender { get; set; }

        protected string EmailReciever { get; set; }

        protected string Message { get; set; }

        public bool SendMail()
        {
            if (!CheckEmailAddress())
            {
                return false;
            }
            if (ValidateMessage())
            {
                return false;
            }
            if (!Connect())
            {
                return false;
            }

            return true;
        }

        protected abstract bool CheckEmailAddress();

        protected abstract bool ValidateMessage();

        protected abstract bool Connect();
    }
}
