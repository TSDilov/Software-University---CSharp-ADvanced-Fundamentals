function search() {
   let array = Array.from(document.getElementById('towns').querySelectorAll('li'));  
   let searchTown = document.getElementById('searchText').value.toLowerCase();
   let matches = 0;
   for (let element of array) {
      let value = element.textContent.toLowerCase();
      if (value.includes(searchTown)) {
         element.style.textDecoration = 'underline';
         element.style.fontWeight = 'bold';
         matches++;
      }
   }

   document.getElementById('result').textContent = `${matches} matches found`;
}
