import { useParams, useSearchParams } from "react-router-dom";

const useHistory = () => {
    const { corpusId } = useParams();
    const [searchParams] = useSearchParams();

    const getStorageKey = (source) => {
        return `${source}_history`;
    };

    const getHistory = (source) => {
        const storageKey = getStorageKey(source);
        return JSON.parse(localStorage.getItem(storageKey)) ?? [];
    };

    const saveSearch = (source) => {
        const query = searchParams.get('query');
        const storageKey = getStorageKey(source);
        let searchItem = { corpusId: corpusId, query: query };

        let currentHistory = getHistory(source);

        // Check if the item already exists in the history
        let searchItemJson = JSON.stringify(searchItem);
        if (!currentHistory.some(x => JSON.stringify(x) === searchItemJson)) {
            var newHistory = [searchItem, ...currentHistory.slice(0, 9)];
            localStorage.setItem(storageKey, JSON.stringify(newHistory));
        }
    };

    return {
        getHistory,
        saveSearch,
    };
};

export default useHistory;