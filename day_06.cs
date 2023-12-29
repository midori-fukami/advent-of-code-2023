namespace advent_of_code_2023
{
    public static class day_06
    {
        public static void part1()
        {
            var result = 1;
            var sum = 0;
            var times = getInputTime();
            var distances = getInputDistance();

            for ( var i = 0; i < times.Count; i++ )
            {
                var minDistance = distances[i];
                for ( var j = 1; j <= times[i]; j++ ) {
                    var total = (times[i] - j) * j;
                    if( total > minDistance ) {
                        sum++;
                    } 
                    //if(sum > 0 && (times[i] - j - 1) * (j-1) > total)
                    //    break;
                }
                result *= sum;
                sum = 0;
            }
            Console.WriteLine(result);
        }

        public static void part2()
        {
            var sum = 0;
            long minDistance = 213116810861248;
            for (long j = 1; j <= 35696887; j++)
            {
                long total = (35696887 - j) * j;
                if (total > minDistance)
                {
                    sum++;
                }
            }
            
            Console.WriteLine(sum);
        }

        public static List<int> getInputTime()
        {
            return "35 69 68 87"
                .Split(" ").Select(int.Parse).ToList();
        }

        public static List<int> getInputDistance()
        {
            return "213 1168 1086 1248"
                .Split(" ").Select(int.Parse).ToList();
        }
    }
}
