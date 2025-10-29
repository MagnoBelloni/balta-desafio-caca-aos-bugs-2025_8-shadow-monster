﻿using BugStore.Application.Orders.Responses;
using BugStore.Domain.Dtos;
using MediatR;

namespace BugStore.Application.Orders.Requests
{
    public class GetOrderRequest : PagedRequestDto, IRequest<PagedResponseDto<GetOrderResponse>>
    {
        public Guid? Id { get; set; }

        public string? CustomerName { get; set; }
        public string? CustomerEmail { get; set; }
        public string? CustomerPhone { get; set; }

        public string? ProductTitle { get; set; }
        public string? ProductDescription { get; set; }
        public string? ProductSlug { get; set; }
        public decimal? ProductPriceStart { get; set; }
        public decimal? ProductPriceEnd { get; set; }

        public DateTime? CreatedAtStart { get; set; }
        public DateTime? CreatedAtEnd { get; set; }
        public DateTime? UpdatedAtStart { get; set; }
        public DateTime? UpdatedAtEnd { get; set; }
    }
}
