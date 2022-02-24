using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShopEnrollmentApp
{
    //Write your code here
    public class TraineeBL
    {
        public bool SaveTraineeDetails(TraineeBO objBo)
        {
            TraineeDA traineeDa = new TraineeDA();
            bool save = traineeDa.AddTraineeDetails(objBo);

            if (save)
            {
                return true;
            }
            return false;
        }
    }
}
