namespace PraktikumADO
{
    internal class MySqlConnection
    {
        private string v;

        public MySqlConnection(string v)
        {
            this.v = v;
        }

        internal void Close()
        {
            throw new NotImplementedException();
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }
    }
}