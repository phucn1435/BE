﻿namespace Project_1.Models
{
    public class Permission
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<RolePermission> RolePermissions { get; set; }
    }
}
