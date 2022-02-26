function solve() {
  Array.from(document.getElementsByClassName('answer-text'))
    .forEach(b => b.addEventListener('click', selectAnswer));

    let rightAnswers = 0;
    let currentQuestionIndex = 0;
    let answeredQuestions = 0;
    let questionsArray = Array.from(document.getElementsByTagName('section'));

    function selectAnswer(event) {
      switch(event.target.textContent) {
        case 'onclick':
        case 'JSON.stringify()':
        case 'A programming API for HTML and XML documents':
          rightAnswers++;       
          break;
      }

      questionsArray[currentQuestionIndex++].style.display = 'none';
      if (currentQuestionIndex <= 2) {
        questionsArray[currentQuestionIndex].style.display = 'block';
      }

      answeredQuestions++;

      if (answeredQuestions === 3) {
        let result = '';
        result = rightAnswers === 3 ? `You are recognized as top JavaScript fan!` :
                                      `You have ${rightAnswers} right answers`;
        document.querySelector('#results li h1').textContent = result;
        document.getElementById('results').style.display = 'block';
      }
    }
}
