using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mini_rpg.Dtos.Character;
using mini_rpg.Dtos.Weapon;

namespace mini_rpg.Services.WeaponService
{
    public interface IWeaponService
    {
        Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon);
    }
}