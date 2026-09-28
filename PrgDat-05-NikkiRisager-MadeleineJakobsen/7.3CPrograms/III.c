void main (){
    int arr [7];

    int arrLength;
    arrLength = 7;

    int max ;
    max = 3;

    arr [0] = 1;
    arr [1] = 2;
    arr [2] = 1;
    arr [3] = 1;
    arr [4] = 1;
    arr [5] = 2;
    arr [6] = 0;

    int freq [4];
    freq [0] = 0;
    freq [1] = 0;
    freq [2] = 0;
    freq [3] = 0;

    histogram(arrLength, arr, max, freq);

    int i;
    
    
    for (i = 0; i <= max; i = i + 1)
        print freq [i];

}

void histogram(int n, int ns[], int max, int freq[]){
    int i;
    
    for (i = 0; i < n; i = i + 1)
        freq [ns [i]] = freq [ns [i]] + 1;
    
}