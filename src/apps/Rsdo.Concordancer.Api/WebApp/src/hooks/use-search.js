import { useLocation, useNavigate, useParams, useSearchParams } from 'react-router-dom';

const useSearch = () => {
    const navigate = useNavigate();
    const { corpusId } = useParams();
    const [searchParams] = useSearchParams();
    const location = useLocation();
    const rootUrl = `/${corpusId}`;

    const newSearch = (source, query) => {
        const link = `/${corpusId}/${source}/search?query=${query}`;
        navigate(link);
    };

    const getSearchLink = (source, query) => {
        return `/${corpusId}/${source}/search?query=${query}`;
    };

    const getSearchRequest = (includePage = true) => {
        // Common properties
        var request = {
            corpusId: corpusId,
        };

        if (includePage) {
            const page = searchParams.get('page') ? searchParams.get('page') : 1;
            const from = (page - 1) * 20;
            const size = 20;

            request['from'] = from;
            request['size'] = size;
        }

        // Query
        if (searchParams.get('query')) {
            request['query'] = searchParams.get('query');

        } else {
            // Main word
            let mainWord = {
                form: searchParams.get('mainWord.form'),
                lemma: searchParams.get('mainWord.lemma'),
                formSearchType: searchParams.get('mainWord.formSearchType'),
            };
            request['mainWord'] = mainWord;

            // Word in context
            let wordsInContext = [];
            for (let i = 0; i < 100; i++) {
                if (searchParams.has('wordInContext[' + i + '].lemma')) {
                    let wordInContext = {
                        form: searchParams.get('wordInContext[' + i + '].form'),
                        lemma: searchParams.get('wordInContext[' + i + '].lemma'),
                        formSearchType: searchParams.get('wordInContext[' + i + '].formSearchType'),
                        distanceType: searchParams.get('wordInContext[' + i + '].distanceType'),
                        leftPosition: searchParams.get('wordInContext[' + i + '].leftPosition'),
                        rightPosition: searchParams.get('wordInContext[' + i + '].rightPosition')
                    };
                    wordsInContext.push(wordInContext);
                }
            }
            if (wordsInContext.length > 0) {
                request['wordsInContext'] = wordsInContext;
            }
        }

        // Filters
        if (searchParams.has('TextIds') === true) {
            request['TextIds'] = searchParams.getAll('TextIds');
        }
        return request;
    };

    const getDetailsRequest = (paragraphId, tokenOrder) => {
        var request = getSearchRequest(false);
        request['ParagraphId'] = paragraphId;
        request['TokenOrder'] = tokenOrder;
        return request;
    };

    const getQuery = () => {
        return searchParams.get('query');
    }

    const getPage = () => {
        return searchParams.get('page');
    }

    const getPagerLink = (page) => {

        searchParams.set('page', page);

        return `${location.pathname}?${searchParams.toString()}`;
    };

    const getFilterLink = (name, key) => {
        let newParams = new URLSearchParams(searchParams);
        newParams.append(name, key);
        return `${location.pathname}?${newParams.toString()}`;
    };

    const getClearFilterLink = (name, key) => {
        var newParams = new URLSearchParams();
        searchParams.forEach((v, k) => {
            if (k !== name || v !== key) {
                newParams.append(k, v);
            }
        });

        return `${location.pathname}?${newParams.toString()}`;
    }

    const isFiltered = (name, key) => {
        var values = searchParams.getAll(name);
        return values.indexOf(key) !== -1;
    };

    const getAlternateSearchLink = (search) => {
        let newParams = new URLSearchParams();
        newParams.append('mainWord.form', search.mainWord.form);
        newParams.append('mainWord.lemma', search.mainWord.lemma);
        newParams.append('mainWord.formSearchType', search.mainWord.formSearchType);

        if (search.wordsInContext) {
            search.wordsInContext.forEach((w, i) => {
                newParams.append('wordInContext[' + i + '].form', w.form);
                newParams.append('wordInContext[' + i + '].lemma', w.lemma);
                newParams.append('wordInContext[' + i + '].formSearchType', w.formSearchType);
                newParams.append('wordInContext[' + i + '].distanceType', w.distanceType);
                newParams.append('wordInContext[' + i + '].leftPosition', 0);
                newParams.append('wordInContext[' + i + '].rightPosition', i + 1);

            });
        }

        return `${location.pathname}?${newParams.toString()}`;
    };

    return {
        corpusId,
        rootUrl,
        newSearch,
        getSearchLink,
        getSearchRequest,
        getDetailsRequest,
        getQuery,
        getPage,
        getPagerLink,
        getFilterLink,
        getClearFilterLink,
        isFiltered,
        getAlternateSearchLink,
    };
};

export default useSearch;
