using System;

namespace methodology
{
    public class RandomComposedStudentFabricator : ComparableFactory
    {
        public override IComparable CreateComparable()
        {

            int amount = RandomDataGenerator.IntegerRandomNumber(20, 1);
            ComposedStudent composedStudent = new ComposedStudent();

            for(int i= 0; i < amount; i++)
            {
                composedStudent.add((IStudent)ComparableFactory.createRandom(6)); // 6 = Proxystudent
            }

            return composedStudent;
        }
    }
}