void main (int n){
    int arr [20];
    
    squares (n, arr);

    int res;
    arrsum (n, arr, &res);
    print res;
}

void squares(int n, int arr[]){
    int i ;
    i = 0;

    while(i < n){
        arr [i] = i * i;
        i = i + 1;
    }
}


void arrsum(int n, int arr[], int *sump){
    int sum;
    sum = 0;

    int i;
    i = 0;

    while (i < n){
        sum = sum + arr [i];
        i = i + 1;
    }
    *sump = sum;
}