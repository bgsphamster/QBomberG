import pyperclip
import pyautogui
import time
import argparse

ap = argparse.ArgumentParser()
ap.add_argument("--message", type=str)
ap.add_argument("--frequency", type=int)
ap.add_argument("--timeout", type=int)
args=ap.parse_args()
message = args.message
frequency = args.frequency
time.sleep(args.timeout)
pyperclip.copy(message)
for i in range(frequency):
    pyautogui.hotkey('ctrl', 'v')
    pyautogui.hotkey('enter')
