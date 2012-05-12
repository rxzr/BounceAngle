﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BounceAngle
{
    class BuildingDataIMP : BuildingData
    {
        private int ammo;
        private int food;
        private int zombies;
        private string description;
        private int id;
        private int survivors;
        private Boolean isOn;

        public BuildingDataIMP(int _id, int _ammo, int _food, int _zombies, string _description, int _survivors, Boolean _isOn)
        {
            id = _id;
            ammo = _ammo;
            food = _food;
            zombies = _zombies;
            description = _description;
            survivors = _survivors;
            isOn = _isOn;
        }
        public Boolean isOver() {
            return isOn;
        }
        public int getAmmo()
        {
            return ammo;
        }

        public int getSurvivors() {
            return survivors;
        }
        public int getFood()
        {
            return food;
        }

        public int getZombies()
        {
            return zombies;
        }

        public string getBuildingDescription()
        {
            return description;
        }

        public int getID()
        {
            return id;
        }

        public void setAmmo(int a) { ammo = a; }
        public void setFood(int f) { food = f; }
        public void setZombies(int z) { zombies = z;  }
        public void setSurvivors(int surv) { survivors = surv;  }
        public void setBuildingDescription(string desc) { description = desc; }
        public void setOver(Boolean over) { isOn = over;  }
    }
}
