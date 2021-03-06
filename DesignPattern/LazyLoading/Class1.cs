﻿using System;
using System.Collections.Generic;

namespace LazyLoading
{
    public static class LazyLoadingFactory
    {
        private static Lazy<Dictionary<string, string>> skill = null;

        static LazyLoadingFactory()
        {
            skill = new Lazy<Dictionary<string, string>>(() => LoadCustomer());
        }

        private static Dictionary<string, string> LoadCustomer()
        {
            Dictionary<string, string> temp = new Dictionary<string, string>();

            temp.Add("javascript", "Requirement matches");
            temp.Add("c#", "Requirement matches");

            return temp;
        }

        public static string Create(string skillType)
        {
            // Design Pattern : RIP Pattern  
            return skill.Value[skillType];
        }
    }
}
