from typing import List


todo_list: List[str] = []


def add_todo() -> None:
    shall_exit_method = False
    while not shall_exit_method:
        description_input = input("Enter TODO description: ")
        if len(description_input) <= 0:
            print("The description cannot be empty.")
        elif description_input not in todo_list:
            todo_list.append(description_input)
            print(f'TODO successfully added: {description_input}')
            shall_exit_method = True
        else:
            print('The description must be unique.')


def show_all_todos() -> bool:
    if len(todo_list) > 0:
        index_count = 1
        for todo in todo_list:
            print(f'{index_count}. {todo}')
            index_count += 1
        return True
    else:
        print("No TODOs have been added yet.")
        return False


def remove_todo() -> None:
    todo_to_remove = input("Select the index of the TODO you want to remove: ")
    removal_index = int(todo_to_remove) - 1
    if todo_to_remove.isnumeric() and removal_index < len(todo_list):
        print(f"TODO removed: {todo_list.pop(removal_index)}")
    else:
        print("The given index is empty or not valid.")


if __name__ == "__main__":
    shall_exit: bool = False
    print("Hello")

    while not shall_exit:
        print("What do you want to do ?")
        print("[S]ee all TODOs")
        print("[A]dd a TODO")
        print("[R]emove a TODO")
        print("[E]xit")

        userInput = input("select one of the given S, A, R, E options: ")

        match userInput:

            case "A" | "a":
                add_todo()

            case "E" | "e":
                shall_exit: bool = True

            case "S" | "s":
                show_all_todos()

            case "R" | "r":
                if show_all_todos():
                    remove_todo()

            case _:
                print("Incorrect input")

        print()
