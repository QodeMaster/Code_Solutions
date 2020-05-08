// Solution

int digitsProduct(int product) {
    if(product == 0) return 10;
    if(product == 1) return 1;
    
    int sum = 0;
    int exponent = 0;

    for(int i = 9; 2 <= i; i--){
        while(product % i == 0) {
            product /= i;
            sum += i * (int)Math.Pow(10, exponent++);
        }
    }

    return product == 1 ? sum : -1;
}
