using AutoMapper;
using GCE.DataAccess.DataObjects;
using GCE.Definitions.Interfaces.Entities;

namespace GCE.Backend
{
    public class MapperConfig
    {
        public static void Setup()
        {
            Mapper.CreateMap<IMessage, Message>();
        }
    }
}