using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Judges.Data.Models;
using Judges.Services;
using Microsoft.AspNetCore.Mvc;

namespace Subscriptions.Controllers


[Route("subscription")]

[ApiController]

public class SubscriptionController : ControllerBase

{

private readonly ISubscriptionService _subscriptionService;

public SubscriptionController(ISubscriptionService subscriptionService)

{

_subscriptionService = subscriptionService;

}



    /// <summary>
        // ��������� �������� �� id.
        /// </summary>
        /// <param name="id">������������� ��������.</param>
   /// <returns>������ ��������.</returns>

[HttpGet]

[Route(nameof(Get))]

public async Task<IActionResult> Get(int id)

{

var subscriptionDto = await _subscriptionService.Get(id);

return Ok(new { Success = true, Subscription = subscriptionDto });

}
    /// <summary>
        // ���������� ��������.
        /// </summary>
        /// <param name="subscriptionDto">������ ��� ����������.</param>
        /// <returns>������������� ����������� ��������.</returns

[HttpPost]

[Route(nameof(Create))]

[Produces("application/json")]

public async Task<IActionResult> Create(SubscriptionDto subscriptionDto)

{
   return Ok(new { Success = true, subscriptionId = await _subscriptionService.Create(subscriptionDto) });

}


// ���������� ��������.

[HttpPost]

[Route(nameof(Update))]

[Produces("application/json")]

public async Task<IActionResult> Update(SubscriptionDto subscriptionDto)

{

return Ok(new { Success = true, SubscriptionId = await _subscriptionService.Update(subscriptionDto) });

}

// ��������

[HttpPost]

[Route(nameof(Delete))]

[Produces("application/json")]

public async Task<IActionResult> Delete(int id)

{

await _subscriptionService.Delete(id);

return Ok(new { Success = true });

}

}

