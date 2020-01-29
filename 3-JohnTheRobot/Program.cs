using System;

namespace _3_JohnTheRobot
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var john = new Humanoid(new Dancing());
            Console.WriteLine(john.ShowSkill()); // print dancing

            var alex = new Humanoid(new Coocking());
            Console.WriteLine(alex.ShowSkill()); // print cooking

            var bob = new Humanoid();
            Console.WriteLine(bob.ShowSkill()); // print no skill is defined

            Console.WriteLine("press any key to exit ...");
            Console.ReadKey();
        }
    }

    #region Humanoid
    public class Humanoid
    {
        private ISkill _skill;

        public Humanoid()
        {

        }

        public Humanoid(ISkill skill)
        {
            _skill = skill;
        }

        public string ShowSkill()
        {
            return _skill == null ? "no skill is defined" : _skill.SkillName;
        }
    } 
    #endregion

    #region Robot Skills
    public interface ISkill
    {
        string SkillName { get; set; }
    }

    public class Dancing : ISkill
    {
        public string SkillName { get; set; }

        public Dancing()
        {
            SkillName = "dancing";
        }
    }

    public class Coocking : ISkill
    {
        public string SkillName { get; set; }

        public Coocking()
        {
            SkillName = "cooking";
        }
    } 
    #endregion
}
