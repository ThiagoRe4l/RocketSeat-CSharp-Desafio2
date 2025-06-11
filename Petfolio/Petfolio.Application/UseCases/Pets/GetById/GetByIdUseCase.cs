using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pets.GetById;

public class GetByIdUseCase
{
    public ResponsePetJson Execute(int id)
    {
        return new ResponsePetJson
        {
            Id = id,
            Name = "Fido",
            Birthday = new DateTime(year: 2023, month: 01, day: 01),
            Type = Communication.Enums.PetType.Dog
        };
    }
}
