const suitArr = ['h', 'c', 'd', 's'];
const valueArr = ['a', 2, 3, 4, 5, 6, 7, 8, 9, 10, 'J', 'Q', 'K'];
const deck = [];
for (let i = 0; i < suitArr.length; i++) {
  for (let j = 0; j < valueArr.length; j++) {
    deck.push(suitArr[i] + ' ' + valueArr[j]);
  }
}
for (let i = 0; i < deck.length; i++) {
  console.log(deck[i]);
}
