import os
from datetime import date

# ✔️ 이 부분만 매일 수정
problems = [
    ("10807", "개수 세기", "Bronze V"),
    ("2577", "숫자의 개수", "Bronze II"),
    ("1475", "방 번호", "Silver V")
]

# 오늘 날짜 자동 처리
today = date.today().strftime("%Y-%m-%d")
month_folder = today[:7]  # yyyy-mm 형식

# 경로 지정 수정
boj_md_path = f"./boj/{month_folder}/{today}.md"
sol_dir = f"./bojSolutions/{month_folder}/{today}"

# 덮어쓰기 방지 확인
if os.path.exists(boj_md_path):
    confirm = input(f"⚠️ {boj_md_path} 이미 존재합니다. 덮어쓸까요? (y/n): ")
    if confirm.lower() != 'y':
        print("🚫 작업을 취소했습니다.")
        exit()

# 폴더 생성
os.makedirs(os.path.dirname(boj_md_path), exist_ok=True)
os.makedirs(sol_dir, exist_ok=True)

# 마크다운 정리 파일 생성
with open(boj_md_path, "w", encoding="utf-8") as f:
    f.write(f"# 📅 {today} 백준 풀이 정리\n\n")
    f.write("| 난이도 | 문제 번호 | 문제 이름 | 정답 코드 | 문제 해결 메모 |\n")
    f.write("| :--: | :--: | :--: | :--: | :--: |\n")
    for number, title, level in problems:
        url = f"https://www.acmicpc.net/problem/{number}"
        code_link = f"../bojSolutions/{today}/{number}.cs"
        memo_link = f"../../bojSolutions/{today}/{number}_memo.md"
        f.write(f"| {level} | {number} | [{title}]({url}) | [정답 코드]({code_link}) | [메모]({memo_link}) |\n")

# 메모 템플릿
memo_template = """# 챕터

## 📝 문제 요약

---

## 🤔 헷갈렸던 점 / 몰랐던 점
- **헷갈린 점**:
- **몰랐던 점**:

---

## ✂️ 간략화 코드
```cs

```

## 🔍 간략화 포인트


"""

# 기본 C# 코드 템플릿
cs_template = """using System;

class Program
{
    static void Main()
    {
        // TODO: 여기에 문제 풀이 코드 작성
    }
}
"""

# 각 문제에 대해 파일 생성 (.cs, _memo.md)
for number, _, _ in problems:
    # 메모 파일
    memo_path = os.path.join(sol_dir, f"{number}_memo.md")
    if not os.path.exists(memo_path):
        with open(memo_path, "w", encoding="utf-8") as f:
            f.write(memo_template)
    
    # C# 코드 파일
    cs_path = os.path.join(sol_dir, f"{number}.cs")
    if not os.path.exists(cs_path):
        with open(cs_path, "w", encoding="utf-8") as f:
            f.write(cs_template)
