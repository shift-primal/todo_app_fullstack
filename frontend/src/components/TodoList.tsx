import { TodoItemType } from "@/types/types";
import { TodoCard } from "./TodoCard";

export const TodoList = ({ data }: { data: TodoItemType[] }) => {
	return (
		<div className="w-3/4 h-fit flex flex-col gap-y-4 mx-auto">
			<h1>To-Do-List</h1>

			{data.map((todo) => (
				<TodoCard todo={todo} />
			))}
		</div>
	);
};
