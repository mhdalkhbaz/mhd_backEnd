﻿namespace ShamiCafe.Models.Common
{
    public interface IBaseEntity<TId>
    {
        public TId Id { get; set; }
    }
}
