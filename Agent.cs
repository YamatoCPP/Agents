//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gayfullin
{
    using System;
    using System.Collections.Generic;
    
    public partial class Agent
    {
        public int Id { get; set; }
        public int AgentTypeID { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Logo { get; set; }
        public string Address { get; set; }
        public int Priority { get; set; }
        public string DirectorName { get; set; }
        public string INN { get; set; }
        public string KPP { get; set; }
    
        public int Discount
        { 
            get 
            {
                return 0;
            } 
        }

        public int Sales
        {
            get
            {
                return 0;
            }
        }
        public string AgentTypeText 
        { 
            get 
            { 
                return AgentType.Title.ToString(); 
            } 
        }
        public virtual AgentType AgentType { get; set; }
    }
}