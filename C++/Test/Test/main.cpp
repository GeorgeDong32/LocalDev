#include <stdio.h>

int main() {
    int a, n;
    scanf("%d", &n);
    while (n > 0) {
        a = n % 10;
        n = n / 10;
        printf("%d",a);
    }
    printf("22250604230\n");
}
