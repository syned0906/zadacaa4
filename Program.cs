using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace zadaca4
{
    interface IPermission
    {
        void Allow();
    }

    public class EditPermission : IPermission
    {
        public void Allow()
        {
            Console.WriteLine("User has Edit permission");
        }
    }

    public class DeletePermission : IPermission
    {
        public void Allow()
        {
            Console.WriteLine("User has Delete permission");
        }
    }

    public class CreatePermission : IPermission
    {
        public void Allow()
        {
            Console.WriteLine("User has Create permission");
        }
    }

    public class ViewPermission : IPermission
    {
        public void Allow()
        {
            Console.WriteLine("User has View permission");
        }
    }

    interface IAccountConfiguration
    {
        void AddEditPermission(EditPermission permission);
        void AddDeletePermission(DeletePermission permission);
        void AddCreatePermission(CreatePermission permission);
        void AddViewPermission(ViewPermission permission);
        void ClearPermission();
    }

    public class PresetPermission : IAccountConfiguration
    {
        public void Admin()
        {
            AddEditPermission(new EditPermission());
            AddDeletePermission(new DeletePermission());
            AddCreatePermission(new CreatePermission());
            AddViewPermission(new ViewPermission());
        }

        public void User()
        {
            AddViewPermission(new ViewPermission());
        }

        public void Manager()
        {
            AddCreatePermission(new CreatePermission());
            AddViewPermission(new ViewPermission());
        }

        public void AddEditPermission(EditPermission permission)
        {
        }

        public void AddDeletePermission(DeletePermission permission)
        {
        }

        public void AddCreatePermission(CreatePermission permission)
        {
        }

        public void AddViewPermission(ViewPermission permission)
        {
           
        }

        public void ClearPermission()
        {
          
        }
    }




}

