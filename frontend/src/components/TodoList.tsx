import {
	Table,
	TableBody,
	TableCaption,
	TableCell,
	TableHead,
	TableHeader,
	TableRow,
} from "@/components/ui/table";
import { TodoItemType } from "@/types/types";

export const TodoList = ({ data }: { data: TodoItemType[] }) => {
	const tableHeaders = [
		"Title",
		"Description",
		"Urgency",
		"Created",
		"Complete by",
		"Completed",
	];

	const tableRows = data.map((todo) => {
		return (
			<TableRow key={todo.id}>
				<TableCell className="font-medium">{todo.title}</TableCell>
				<TableCell>
					{todo.description ? todo.description : "-"}
				</TableCell>
				<TableCell>{todo.urgency}</TableCell>
				<TableCell>
					{todo.createdAt
						? new Date(todo.createdAt).toLocaleDateString()
						: "-"}
				</TableCell>
				<TableCell>
					{todo.completeBy
						? new Date(todo.completeBy).toLocaleDateString()
						: "-"}
				</TableCell>
				<TableCell className="text-right">
					{todo.isCompleted ? "Yes" : "No"}
				</TableCell>
			</TableRow>
		);
	});

	return (
		<Table className="w-xl bg-card">
			<TableCaption>Todos</TableCaption>
			<TableHeader>
				<TableRow>
					{tableHeaders.map((th) => (
						<TableHead key={th}>{th}</TableHead>
					))}
				</TableRow>
			</TableHeader>
			<TableBody>{tableRows}</TableBody>
		</Table>
	);
};
