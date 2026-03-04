import { TodoQueryParams } from "@/types/types";
import { Dispatch, SetStateAction } from "react";
import { DatePickerWithRange } from "./querycontrols/DatePickerWithRange";
import { SearchInput } from "./querycontrols/SearchInput";

export const QueryControls = ({
	setQuery,
}: {
	setQuery: Dispatch<SetStateAction<TodoQueryParams>>;
}) => {
	return (
		<div id="query-controls" className="flex gap-4">
			<SearchInput setQuery={setQuery} />
			<DatePickerWithRange setQuery={setQuery} />
		</div>
	);
};
