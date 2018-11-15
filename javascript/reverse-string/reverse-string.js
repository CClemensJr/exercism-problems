export const reverseString = (str) => {
  const strArr = str.split('');
  const rts = [];

  strArr.forEach((char) => {
    rts.unshift(char);
  });

  return rts.join('');
};
