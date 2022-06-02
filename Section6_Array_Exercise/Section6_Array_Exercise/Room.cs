namespace Section6_Array_Exercise
{
    class Room
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return string.Format("{0}, {1}", Name, Email);
        }
    }
}
