﻿using Application.IRepository;
using Application.IServices;
using AutoMapper;
using Domain.Entities;

namespace Application.Services
{
    public class CheckRoleService : ICheckRoleService
    {
        private readonly IRequestRepository _requestRepository;
        private readonly IMapper _mapper;

        public CheckRoleService(IRequestRepository requestRepository , IMapper mapper)
        {
            _requestRepository = requestRepository;
            _mapper = mapper;
        }


        public async Task<bool> CheckRole(Request request)
        {
           
            if (request.role == "assistante" || request.role == "traitant")
            {
                return false;
            }

           
            return true;
        }
    }
}