﻿using Demo.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Interfaces
{
    public interface IUtilisateurService
    {
        void RegisterUtilisateur(IUtilisateurModel model);
    }
}
