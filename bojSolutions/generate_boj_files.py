import os
from datetime import date

# ✔️ 여기만 매일 수정!
problems = [
    ("10807", "개수 세기", "Bronze V"),
    ("2577", "숫자의 개수", "Bronze II"),
    ("1475", "방 번호", "Silver V")
]

# 오늘 날짜로 자동 처리 (또는 직접 입력도 가능)
today = date.today().strftime("%Y-%m-%d")
# today = "2025-05-18"  # 수동 날짜 설정 시 이 줄로 변경

boj_md_path = f"./boj/{today}.md"
sol_dir = f"./bojSolutions/{today}"

os.makedirs(sol_dir, exist_ok=True)

# boj/날짜.md 작성
with open(boj_md_path, "w", encoding="utf-8") as f:
    f.write(f"# 📅 {today} 백준 풀이 정리\n\n")
    f.write("| 난이도 | 문제 번호 | 문제 이름 | 정답 코드 | 문제 해결 메모 |\n")
    f.write("| :--: | :--: | :--: | :--: | :--: |\n")
    for number, title, level in problems:
        url = f"https://www.acmicpc.net/problem/{number}"
        code_link = f"../bojSolutions/{today}/{number}.cs"
        memo_link = f"../../bojSolutions/{today}/{number}_memo.md"
        f.write(f"| {level} | {number} | [{title}]({url}) | [정답 코드]({code_link}) | [메모]({memo_link}) |\n")

# bojSolutions 내부 파일들 생성
memo_template = """# 챕터

## 📝 문제 요약

---

## 🤔 헷갈렸던 점 / 몰랐던 점
- **헷갈린 점**:
- **몰랐던 점**:

---

## ✂️ 간략화 코드
```cs

