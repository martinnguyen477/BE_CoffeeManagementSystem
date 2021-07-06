using AutoMapper;
using CoffeeManagementSystem.Model.EntitiesModel;
using CoffeeManagementSystem.Model.Model;

namespace CoffeeManagementSystem.API.ProjectMapper
{
    public class AttributeValueOrderDetailMapper : Profile
    {
        public AttributeValueOrderDetailMapper()
        {
            CreateMap<AttributeValueOrderDetailModel, AttributeValueOrderDetailEntities>();
            CreateMap<AttributeValueOrderDetailEntities, AttributeValueOrderDetailModel>();
        }

    }
}
