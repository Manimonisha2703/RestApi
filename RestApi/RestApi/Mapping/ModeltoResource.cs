using AutoMapper;
using RestApi.Domain.Model;
using RestApi.Resources;

namespace RestApi.Mapping
{
    public class ModeltoResource : Profile
    {
        public ModeltoResource() {

            CreateMap<Category, CategoryResource>();

        }
    }
}
