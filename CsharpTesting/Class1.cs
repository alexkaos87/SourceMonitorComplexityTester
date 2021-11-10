namespace alexkaos
{
    public class Class1
    {
        // complexity = 4, Statements = 4, Max Depth = 4, Calls = 2
        // modified complexity = 4*, Statements = 4, Max Depth = 4, Calls = 2
        public void FunctionWith3If()
        {
            var variable1 = new Random().NextInt64();
            if (variable1 > 0)
            {
                if (variable1 < 1000)
                {
                    if (variable1 > 100)
                    {
                        // TODO
                    }
                }
            }
        }

        // complexity = 13, Statements = 25, Max Depth = 4, Calls = 2
        // modified complexity = 2*, Statements = 25, Max Depth = 4, Calls = 2
        public void FunctionWith1SwitchAnd10Cases()
        {
            var variable1 = new Random().NextInt64();

            switch (variable1)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    break;
                default:
                    break;
            }
        }

        // complexity = 16, Statements = 28, Max Depth = 4, Calls = 2
        // modified complexity = 5*, Statements = 28, Max Depth = 4, Calls = 2
        public void FunctionWith3IfAnd1SwitchAnd10Cases()
        {
            var variable1 = new Random().NextInt64();
            if (variable1 > 0)
            {
                if (variable1 < 1000)
                {
                    if (variable1 > 100)
                    {
                        // TODO
                    }
                }
            }

            switch (variable1)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    break;
                default:
                    break;
            }
        }
    }
}