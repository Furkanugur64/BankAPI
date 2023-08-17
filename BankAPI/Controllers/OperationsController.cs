using AutoMapper;
using BusinessLayer.Abstract;
using DTOLayer.DTOs.Operations;

//using DTOLayer.DTOs.Operations;
using DTOLayer.DTOs.TransactionDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BankAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationsController : ControllerBase
    {
        private readonly ITransactionService _transactionService;
        private readonly IMapper _mapper;

        public OperationsController(ITransactionService transactionService, IMapper mapper)
        {
            _transactionService = transactionService;
            _mapper = mapper;
        }

        [HttpPost("Deposit")]
        public IActionResult Deposit(DepositDto depositDto)
        {
            _transactionService.TDeposit(depositDto);
            return Ok("Hesabınıza Para Yatırıldı");
        }

        [HttpPost("SendMoney")]
        public IActionResult SendMoney(SendMoneyDto sendMoneyDto)
        {
            _transactionService.TSendMoney(sendMoneyDto);
            return Ok("Para Gönderme İşlemi Başarılı");
        }
    }
}
