'''
22.01.10

문자열 반복 다국어
 
시간 제한	메모리 제한	제출	정답	맞힌 사람	정답 비율
1 초	128 MB	101637	51659	44594	51.324%
문제
문자열 S를 입력받은 후에, 각 문자를 R번 반복해 새 문자열 P를 만든 후 출력하는 프로그램을 작성하시오. 즉, 첫 번째 문자를 R번 반복하고, 두 번째 문자를 R번 반복하는 식으로 P를 만들면 된다. S에는 QR Code "alphanumeric" 문자만 들어있다.

QR Code "alphanumeric" 문자는 0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ\$%*+-./: 이다.

입력
첫째 줄에 테스트 케이스의 개수 T(1 ≤ T ≤ 1,000)가 주어진다. 각 테스트 케이스는 반복 횟수 R(1 ≤ R ≤ 8), 문자열 S가 공백으로 구분되어 주어진다. S의 길이는 적어도 1이며, 20글자를 넘지 않는다. 

출력
각 테스트 케이스에 대해 P를 출력한다.

예제 입력 1 
2
3 ABC
5 /HTP
예제 출력 1 
AAABBBCCC
/////HHHHHTTTTTPPPPP
출처


ICPC > Regionals > North America > Greater New York Region > 2011 Greater New York Programming Contest A번

문제를 번역한 사람: baekjoon
문제의 오타를 찾은 사람: jh05013
잘못된 데이터를 찾은 사람: pichulia
알고리즘 분류
구현
문자열
'''
N=int(input()) # 테스트케이스 개수만큼 반복
for i in range(N):
  R, S=input().split() # 공백으로 입력받아 반복횟수 R 과 문자열 S 를 따로 입력받는다.
  P=''                 # 테스트케이스가 넘어갈떄마다 문자열 초기화

  for j in S: # 문자열 S에서 한 문자씩 가져와서 반복횟수 R만큼 곱해주고 계속 더 한다.
    P+=j*int(R)

  print(P)



    
 

