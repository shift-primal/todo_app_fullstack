import { TodoItemType, UrgencyLevel } from "@/types/types";
import { Checkbox } from "./ui/checkbox";
import clsx from "clsx";

export const TodoCard = ({ todo }: { todo: TodoItemType }) => {
	const urgencyTable: Record<UrgencyLevel, { cn: string; icon: string }> = {
		None: {
			cn: "text-green-400",
			icon: "!",
		},
		Low: {
			cn: "text-amber-400 font-semibold",
			icon: "!!",
		},
		Medium: {
			cn: "text-orange-400 font-semibold",
			icon: "!!!",
		},
		High: {
			cn: "text-red-400 font-bold",
			icon: "!!!!",
		},
	};

	const parseDate = (date: string) =>
		new Date(date).toLocaleDateString("nb-NO");

	return (
		<div className="bg-card w-full h-fit rounded-lg px-4 py-6 flex justify-center gap-4">
			<Checkbox
				className="rounded-full self-center cursor-pointer"
				checked={todo.isCompleted}
			/>
			<div id="title-date" className="flex-11/12">
				<span className="text-sm">{parseDate(todo.createdAt!)}</span>
				<h1>{todo.title}</h1>
			</div>
			<span
				className={clsx(
					urgencyTable[todo.urgency ?? "None"].cn,
					"self-center",
				)}
			>
				{urgencyTable[todo.urgency ?? "None"].icon}
			</span>
		</div>
	);
};
