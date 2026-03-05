import {
	Select,
	SelectContent,
	SelectGroup,
	SelectItem,
	SelectTrigger,
	SelectValue,
} from "@/components/ui/select";
import { TodoQueryParams, SortBy, SortDir } from "@/types/types";
import { Dispatch, SetStateAction } from "react";
import { Button } from "../ui/button";
import { ArrowDown, ArrowUp } from "lucide-react";

type Props = {
	query: TodoQueryParams;
	setQuery: Dispatch<SetStateAction<TodoQueryParams>>;
};

export const SortSelection = ({ query, setQuery }: Props) => {
	const selectItemOptions: Array<SortBy> = [
		"Date",
		"Name",
		"Status",
		"Urgency",
	];

	const handleItemSelection = (by: SortBy) => {
		setQuery((q) => ({
			...q,
			SortBy: by,
		}));
	};

	const handleDirSelection = (dir: SortDir) => {
		setQuery((q) => ({
			...q,
			SortDir: dir,
		}));
	};

	return (
		<>
			<div id="select-item-sort">
				<Select onValueChange={handleItemSelection}>
					<SelectTrigger className="w-45">
						<SelectValue placeholder="Sort by" />
					</SelectTrigger>
					<SelectContent>
						<SelectGroup>
							{selectItemOptions.map((s) => (
								<SelectItem value={s}>{s}</SelectItem>
							))}
						</SelectGroup>
					</SelectContent>
				</Select>
			</div>
			<div>
				<Button
					variant="outline"
					onClick={() =>
						handleDirSelection(
							query.SortDir === "Asc" ? "Desc" : "Asc",
						)
					}
				>
					{query.SortDir === "Asc" ? <ArrowUp /> : <ArrowDown />}
				</Button>
			</div>
		</>
	);
};
