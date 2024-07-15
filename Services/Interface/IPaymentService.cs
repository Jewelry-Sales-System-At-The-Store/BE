﻿using BusinessObjects.Dto;
using BusinessObjects.Dto.ResponseDto;

namespace Services.Interface;

public interface IPaymentService
{
    Task<BillCheckoutResponse> CheckoutBill(PaymentRequestDto paymentRequestDto);
}