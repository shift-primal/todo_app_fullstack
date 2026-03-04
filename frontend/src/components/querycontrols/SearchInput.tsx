import { TodoQueryParams } from "@/types/types";
import { SearchIcon } from "lucide-react";
import { Dispatch, SetStateAction } from "react";
import {
	InputGroup,
	InputGroupInput,
	InputGroupAddon,
} from "@/components/ui/input-group";
import { Field } from "@/components/ui/field";

export const SearchInput = ({
	setQuery,
}: {
	setQuery: Dispatch<SetStateAction<TodoQueryParams>>;
}) => {
	return (
		<Field className="max-w-sm">
			<InputGroup>
				<InputGroupInput
					id="inline-start-input"
					placeholder="Search..."
					onChange={(e) =>
						setQuery((q) => ({
							...q,
							Search: e.target.value || undefined,
						}))
					}
				/>
				<InputGroupAddon align="inline-start">
					<SearchIcon className="text-muted-foreground" />
				</InputGroupAddon>
			</InputGroup>
		</Field>
	);
};
