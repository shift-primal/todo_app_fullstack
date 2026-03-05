import {
	Dialog,
	DialogContent,
	DialogDescription,
	DialogHeader,
	DialogTitle,
	DialogTrigger,
} from "@/components/ui/dialog";
import { Button } from "./ui/button";
import { Plus } from "lucide-react";

export const AddTodo = () => {
	return (
		<Dialog>
			<DialogTrigger>
				{<Button className="bg-green-700">{<Plus />}</Button>}
			</DialogTrigger>
			<DialogContent>
				<DialogHeader>
					<DialogTitle>Lag ny todo</DialogTitle>
					<DialogDescription>Bla bla bla</DialogDescription>
				</DialogHeader>
			</DialogContent>
		</Dialog>
	);
};
