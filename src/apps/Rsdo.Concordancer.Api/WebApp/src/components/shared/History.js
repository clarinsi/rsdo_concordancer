import { useTranslation } from 'react-i18next';

import SearchDropdown from "./SearchDropdown";
import HistoryItem from "./HistoryItem";
import styles from './History.module.scss';
import useHistory from "../../hooks/use-history";

const History = (props) => {
    // Hooks
    const { t } = useTranslation();
    const history = useHistory();

    const source = props.source;

    return (
        <SearchDropdown>
            <div className={styles.history}>
                <h3>{t('shared.searchHistory')}</h3>
                <ul className={styles.historyList}>
                    {history.getHistory(props.source).map((x, i) => <HistoryItem key={i} source={source} query={x.query} />)}
                </ul>
            </div>
        </SearchDropdown>
    );
};

export default History;