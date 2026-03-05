import { TodoQueryParams } from "@/types/types";
import { Dispatch, SetStateAction } from "react";
import { DatePickerWithRange } from "./querycontrols/DatePickerWithRange";
import { SearchInput } from "./querycontrols/SearchInput";
import { SortSelection } from "./querycontrols/SortSelection";
import { AddTodo } from "./AddTodo";

type Props = {
	query: TodoQueryParams;
	setQuery: Dispatch<SetStateAction<TodoQueryParams>>;
};

export const QueryControls = ({ query, setQuery }: Props) => {
	return (
		<div id="query-controls" className="flex gap-4">
			<DatePickerWithRange setQuery={setQuery} />
			<SearchInput setQuery={setQuery} />
			<SortSelection query={query} setQuery={setQuery} />
			<AddTodo />
		</div>
	);
};
