﻿using Orders.Shared.DTOs;
using Orders.Shared.Entities;
using Orders.Shared.Responses;

namespace Orders.Backend.Repositories.Interfaces
{
    public interface ICountriesRepository
    {

        Task<IEnumerable<Country>> GetComboAsync();

        Task<ActionResponse<Country>> GetAsync(int id);

        Task<ActionResponse<IEnumerable<Country>>> GetAsync(PaginationDTO pagination);

        Task<ActionResponse<IEnumerable<Country>>> GetAsync();

        Task<ActionResponse<int>> GetTotalPagesAsync(PaginationDTO pagination);
    }

}
