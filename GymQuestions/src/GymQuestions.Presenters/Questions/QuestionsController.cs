using GymQuestions.Application.Questions;
using GymQuestions.Contracts;
using GymQuestions.Contracts.Questions;
using Microsoft.AspNetCore.Mvc;

namespace GymQuestions.Presenters.Questions;

[ApiController]
[Route("[controller]")]
public class QuestionsController : ControllerBase
{
   private readonly IQuestionsService _questionsService;

   public QuestionsController(IQuestionsService questionsService)
   {
      _questionsService = questionsService;
   }
   
   
   [HttpPost]
   // IActionResult - гарантирует возврат результата
   public async Task<IActionResult> Create(
      [FromBody] CreateQuestionDto request, 
      CancellationToken cancellationToken)
   {
      var questionId = await _questionsService.Create(request, cancellationToken);
      return Ok(questionId); // OK() - возвращает код 200 и какой-либо результат 
   }

   [HttpGet]
   public async Task<IActionResult> GetAll(
      [FromQuery] GetQuestionsDto request, 
      CancellationToken cancellationToken)
   {
      return Ok("Questions retrieved");
   }
   
   [HttpGet("{questionId:guid}")]
   public async Task<IActionResult> GetById(
      [FromRoute]  Guid questionId, 
      CancellationToken cancellationToken)
   {
      return Ok("Questions retrieved");
   }
   
   [HttpPut("{questionId:guid}")]
   public async Task<IActionResult> Update(
      [FromRoute]  Guid questionId, 
      [FromBody] UpdateQuestionDto request, 
      CancellationToken cancellationToken)
   {
      return Ok("Questions updated");
   }
   
   [HttpDelete("{questionId:guid}")]
   public async Task<IActionResult> Delete(
      [FromRoute]  Guid questionId, 
      CancellationToken cancellationToken)
   {
      return Ok("Questions deleted");
   }

   [HttpGet("{questionId:guid}/solution")]
   public async Task<IActionResult> SelectSolution(
      [FromRoute] Guid questionId, 
      [FromQuery] Guid answerId,
      CancellationToken cancellationToken)
   {
      return Ok("Solutions selected");
   }
   
   [HttpPost("{questionId:guid}/answers")]
   public async Task<IActionResult> AddAnswer(  
      [FromRoute] Guid questionId,
      [FromBody] AddAnswerDto request, 
      CancellationToken cancellationToken)
   {
      return Ok("Answer added"); // OK() - возвращает код 200 и какой-либо результат 
   }
}

