using System;

class Program
{
    static void Main(string[] args)
    {
        int t = int.Parse(Console.ReadLine());

        for (int i = 0; i < t; i++)
        {
            int n = int.Parse(Console.ReadLine());
            int[] skills = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

           
            

            int maxDistinctSkills = GetMaxDistinctSkills(n, skills);
            Console.WriteLine(maxDistinctSkills);
        }
    }

    static int GetMaxDistinctSkills(int n, int[] skills)
    {
        Array.Sort(skills);
        if (skills.Length == 1)
        {
           
            return 0;
        }

        int maxDistinctSkills = 1;
        int maxSameSkills = 1;
        int sameSkillCounter = 1;

        for (int i = 1; i < n; i++)
        {
            if (skills[i] == skills[i - 1])
            {
                sameSkillCounter++;
                maxSameSkills = Math.Max(maxSameSkills,sameSkillCounter);

            }
            else
            {
                maxDistinctSkills++;
                maxSameSkills = Math.Max(maxSameSkills,sameSkillCounter);
                
                sameSkillCounter = 1;
            }
        }

        if (maxDistinctSkills == maxSameSkills) maxSameSkills--;
        
        maxDistinctSkills = Math.Min(maxDistinctSkills, maxSameSkills);
        return maxDistinctSkills;
    }
}