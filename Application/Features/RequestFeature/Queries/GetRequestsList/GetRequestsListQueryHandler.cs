﻿using Application.Interfaces;
using Application.IUOW;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.RequestFeature.Queries.GetRequestsList;

public class GetRequestsListQueryHandler : IRequestHandler<GetRequestsListQuery,List<Request>>
{
    private readonly IUnitOfService _uos;
    private readonly IMapper _mapper;

    public GetRequestsListQueryHandler(IUnitOfService uos, IMapper mapper)
    {
        _uos = uos;
        _mapper = mapper;
    }

    public async Task<List<Request>> Handle(GetRequestsListQuery request, CancellationToken cancellationToken)
    {
        List<Request> requests = await _uos.RequestService.GetRequestsListAsync();
        return requests;

    }
}